import { SafeAreaView, StyleSheet, Text, View, StatusBar} from 'react-native';
import Person from './src/components/Person/Person';

export default function App() {
  return (
    <SafeAreaView style={styles.container} >
      <StatusBar/>
      <Person name="Teste" age={69}/>
      <Person name="Teste2" age={29}/>
      <Person name="Teste3" age={39}/>
      <Person name="Teste4" age={64}/>
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1
  },
});
