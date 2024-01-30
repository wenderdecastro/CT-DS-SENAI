import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, Touchable, TouchableOpacity, View, Image } from 'react-native';
import { Container } from './src/components/container';
import { useState } from 'react';
import { Button, ButtonText } from './src/components/button/button';
import { useFonts , Montserrat_600SemiBold, Montserrat_800ExtraBold } from '@expo-google-fonts/montserrat'
import { Title } from './src/components/title/title';


export default function App() {

  const [count, setCount] = useState(0); 

  const increment = () => {
    setCount(count + 1)
  }

  const decrement = () => {
    setCount(count - 1)
  }

  let[fontsLoaded, fontError] = useFonts({
    Montserrat_600SemiBold,
    Montserrat_800ExtraBold
  })

  if(!fontsLoaded && !fontError){
    return null;
  }

  return (
    <Container>

    <Image style={styles.picture} source={{uri : "https://i.ibb.co/3WwH7Sy/D-NQ-NP-923859-MLB69539659612-052023-O.png"}}/>

      <Title>Contador: {count}</Title>

      <Button onPress={increment} buttonColor="#b0f2c2">
        <ButtonText>Incremento</ButtonText>
      </Button>

      <Button onPress={decrement} buttonColor="#ffb6af">
        <ButtonText>Decremento</ButtonText>
      </Button>

      <StatusBar style="auto" />
    </Container>
  );
}

const styles = StyleSheet.create({
  picture:{
    width:"80%",
    height: "30%"
  },
});
