import { StatusBar } from 'expo-status-bar';
import { Image, StyleSheet, Text, TextInput, View } from 'react-native';

export default function App() {
  return (
    <View style={styles.container}>
      <Image style={styles.image} source={{ uri: 'https://i.ibb.co/BN1SRpF/125275495.jpg',}}/>
      <Text style={styles.text}>Hello World</Text>
      <StatusBar style="auto" />  
      <TextInput style={styles.input} placeholder='React Native'/>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#222',
    alignItems: 'center',
    justifyContent: 'center',
  },
  image:{
    width: 300,
    height: 300,
    marginVertical: 30
  },
  text:{
    fontSize: 42,
    color: '#49afef'
  },
  input:{
    width: '80%' ,
    height: 40,
    margin: 30,
    borderWidth: 2,
    borderColor: 'transparent',
    borderBottomColor: '#49afef',
    color: '#fff',
    textAlign: 'center',
    fontSize: 18
  }
});
