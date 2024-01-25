import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text,TextInput, View, Image, TouchableOpacity  } from 'react-native';

export default function App() {
  return (
    <View style={styles.container}>
      <Image
        style={styles.image}
        source={{uri: 'https://reactnative.dev/img/tiny_logo.png',}}/>
      <Text style={styles.title}>Login</Text>

      <View style={styles.inputContainer}>
        <Text Text style={styles.label}>Email</Text>
        <TextInput placeholderTextColor={'#ffffff'} style={styles.input} placeholder='Email'/>
      </View>
      
      <View style={styles.inputContainer}>
        <Text style={styles.label}>Senha</Text>
        <TextInput placeholderTextColor={'#ffffff'} style={styles.input} placeholder='Senha'/>
      </View>

      <TouchableOpacity title='Entrar' style={styles.loginButton}>
        <Text style={{color: '#000', fontSize: 18}}>Entrar</Text>
      </TouchableOpacity>

      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#222',
    alignItems: 'center',
    justifyContent: 'center',
    gap: 20
  },
  image:{
    width: 50,
    height: 50,
  },
  title:{
    fontSize: 42,
    color: '#61dafb',
    fontWeight: 'bold'
  },
  label:{
    fontSize: 14,
    color: '#61dafb',
    fontWeight: 'bold'
  },
  input:{
    borderWidth: 2,
    borderColor: 'white',
    borderRadius: 30,
    borderBottomColor: '#ffffff',
    color: '#ffffff',
    textAlign: 'center',
    fontSize: 18    
  },
  inputContainer:{
    width: '80%' ,
    height: 40,
    marginBottom: 20,
    gap: 10
  },
  loginButton:{
    width: 150,
    height: 40,
    backgroundColor: '#61dafb',
    alignItems: 'center',
    justifyContent: 'center',
    marginTop: 20,
    borderRadius: 30
  }
});
