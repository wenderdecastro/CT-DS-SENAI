import { useEffect, useState } from "react";
import { ContainerInput } from "../../components/containerinput";
import { ContainerForm, InputGroup, ScrollForm } from "./style";
import { api } from "../../../services/apiservice";

export function Home(){

	const[cep, setCep] = useState('')
	const[adress, setAdress] = useState({cep:"47400-000", logradouro: "", bairro:"", localidade:"Xique-Xique", uf: "BA"});

	useEffect( async() => {
		LoadData()
	},[]);

	async function LoadData(cep){
		if(cep.length !== 9) return;

		try {
			const response = await api.get(`${cep}/json`);
			const data = await response.data;

			if(response.data){
				setAdress({
					cep: data.cep,
					logradouro: data.logradouro,
					localidade: data.localidade,
					uf: data.uf,
					bairro: data.bairro
				})

				console.log(data);
				return;
			}

			console.log("Endereço não encontrado");
		} catch (error) {

			console.error("Erro ao buscar o endereço. Cod. erro: "+ error)
			
		}
		

		

		
		
		
	}

    return (
		<ScrollForm>
			<ContainerForm>
				<ContainerInput
					textLabel="CEP"
					maxLenght={9}
					placeholder="ex: 12345-123"
					editable={true}
					onChangeText={(text) => {setCep(text)}}
					fieldValue={cep}
				/>
				<ContainerInput
					textLabel="Logradouro"
					placeholder="ex: Rua Fulano de Tal..."
					editable={true}
					fieldValue={adress.logradouro}
				/>
				<ContainerInput
					textLabel="Bairro"
					maxLenght={9}
					placeholder="ex: Jardim ciclano"
					editable={true}
					fieldValue={adress.bairro}
				/>
				<ContainerInput
					textLabel="Cidade"
					maxLenght={9}
					placeholder="ex: Xique-Xique"
					editable={true}
					fieldValue={adress.localidade}
				/>
				<InputGroup>
				<ContainerInput
					textLabel="Estado"
					maxLenght={9}
					placeholder="ex: Bahia"
					fieldWidth={62.5}
					editable={true}

				/>
				<ContainerInput
					textLabel="UF"
					maxLenght={9}
					placeholder="UF"
					fieldWidth={30}
					editable={true}
					fieldValue={adress.uf}
				/>
				</InputGroup>
			</ContainerForm>
		</ScrollForm>
	);
}