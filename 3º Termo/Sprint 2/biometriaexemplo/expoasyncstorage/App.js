import { StatusBar } from 'expo-status-bar';
import { Alert, StyleSheet, Text, TouchableOpacity, View } from 'react-native';

import * as LocalAuth from 'expo-local-authentication';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { useEffect, useState } from 'react';
import moment, { fn } from 'moment';

export default function App() {
	const [history, setHistory] = useState({});
	const [authenticated, setAuthenticated] = useState(false);
	const [biometricExist, setBiometricExist] = useState(false);

	async function CheckExistAuthenticates() {
		const compatible = await LocalAuth.hasHardwareAsync();

		setBiometricExist(compatible);

		const types =
			await LocalAuth.supportedAuthenticationTypesAsync();
		console.log(LocalAuth.AuthenticationType[types[0]]);
	}

	async function SetHistory() {
		const objAuth = {
			dateAuthenticate: moment().format(
				'DD/MM/YYYY HH:mm:ss',
			),
		};

		await AsyncStorage.setItem(
			'authenticate',
			JSON.stringify(objAuth),
		);

		setHistory(objAuth);
	}

	async function getHistory() {
		const objAuth = await AsyncStorage.getItem('authenticate');
		if (objAuth) {
			setHistory(JSON.parse(objAuth));
		}
	}

	async function handleAuthentication() {
		const biometric = await LocalAuth.isEnrolledAsync();

		if (!biometric) {
			return Alert.alert(
				'Falha ao logar',
				'Não foi encontrada nenhuma biometria cadastrada.',
			);
		}

		const auth = await LocalAuth.authenticateAsync({
			promptMessage: 'Login com Biometria',
		});

		setAuthenticated(auth.success);
		SetHistory();
	}
	useEffect(() => {
		CheckExistAuthenticates();
		getHistory();
	}, []);

	return (
		<View style={styles.container}>
			<Text style={styles.title}>
				{biometricExist
					? 'Seu dispositivo é compatível com a Biometria'
					: 'Seu dispositivo não é compatível com os recursos de autenticação biométrica'}
			</Text>

			<TouchableOpacity
				style={styles.btn}
				onPress={() => handleAuthentication()}
			>
				<Text style={styles.txt}>Autenticar</Text>
			</TouchableOpacity>

			<Text
				style={[
					{
						color: authenticated
							? 'green'
							: 'red',
					},
					styles.txtReturn,
				]}
			>
				{authenticated
					? 'Autenticado'
					: 'Não autenticado'}
			</Text>

			{history.dateAuthenticate ? (
				<Text style={styles.txtHistory}>
					Último acesso :{' '}
					{history.dateAuthenticate}
				</Text>
			) : null}
			<StatusBar style="auto" />
		</View>
	);
}

const styles = StyleSheet.create({
	container: {
		flex: 1,
		backgroundColor: '#fff',
		alignItems: 'center',
		justifyContent: 'center',
	},
	title: {
		fontSize: 20,
		textAlign: 'center',
		lineHeight: 30,
		width: '60%',
	},
	btn: {
		padding: 16,
		borderRadius: 15,
		margin: 20,
		backgroundColor: '#ED3345',
		width: '50%',
	},
	txt: {
		color: '#fff',
		fontWeight: 'bold',
		textAlign: 'center',
	},
	txtReturn: {
		fontSize: 22,
		textAlign: 'center',
		marginTop: 50,
	},
	txtHistory: {
		fontSize: 16,
		margin: 20,
		fontWeight: 'bold',
		color: '#858383',
		position: 'absolute',
		bottom: 120,
	},
});
