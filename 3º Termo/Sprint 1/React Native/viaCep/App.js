import { StatusBar } from "react-native";
import { StyleSheet, Text, View } from "react-native";
import { useFonts } from "expo-font";
import { ContainerApp } from "./styles";
import { Header } from "./src/components/header";
import {
  Roboto_700Bold,
  Roboto_500Medium,
  Roboto_400Regular,
} from "@expo-google-fonts/roboto";
import { Home } from "./src/screens/Home";

export default function App() {

  let [fontsLoaded, fontError] = useFonts({
    Roboto_700Bold,
    Roboto_500Medium,
    Roboto_400Regular,
  });

  if(!fontsLoaded && fontError){
    return null;
  };

  return (
    <ContainerApp>
      <StatusBar />
      <Header/>
      <Home/>
    </ContainerApp>
  );
}

// const styles = StyleSheet.create({
//   container: {
//     flex: 1,
//     backgroundColor: '#fff',
//     alignItems: 'center',
//     justifyContent: 'center',
//   },
// });
