import { useEffect, useState } from "react";
import { ContainerInput } from "../../components/containerinput";
import { ContainerForm, InputGroup, ScrollForm } from "./style";
import { api, getCep } from "../../../services/apiservice";

export function Home() {
	const [cep, setCep] = useState("08580-250");
	const [adress, setAdress] = useState({});

	useEffect(() => {
		getAdress();
	}, [cep]);

	async function getAdress() {
		if (cep.length == 8) {
			const add = await getCep(cep);
			if(add == undefined) return;
			setAdress(add);
		}
	}

	return (
		<ScrollForm>
			<ContainerForm>
				<ContainerInput
					textLabel="CEP"
					maxLenght={8}
					placeholder="ex: 12345-123"
					editable={true}
					fieldValue={cep}
					onChangeText={(tx) => setCep(tx)}
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
						fieldValue={adress.estado}
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
