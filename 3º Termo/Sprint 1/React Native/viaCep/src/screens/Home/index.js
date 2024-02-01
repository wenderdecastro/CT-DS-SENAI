import { ContainerInput } from "../../components/containerinput";
import { ContainerForm, ScrollForm } from "./style";

export function Home(){
    return (
		<ScrollForm>
			<ContainerForm>
				<ContainerInput
					textLabel="CEP"
					maxLenght={9}
					placeholder="Cep..."
					fieldWidth={100}
				/>
				<ContainerInput
					textLabel="Longradouro"
					placeholder="Longradouro"
					fieldWidth={100}
				/>
				<ContainerInput
					textLabel="Bairro"
					maxLenght={9}
					placeholder="Bairro"
					fieldWidth={100}
				/>
				<ContainerInput
					textLabel="Cidade"
					maxLenght={9}
					placeholder="Cidade"
					fieldWidth={100}
				/>
				<ContainerInput
					textLabel="Estado"
					maxLenght={9}
					placeholder="Estado"
					fieldWidth={60}
				/>
				<ContainerInput
					textLabel="UF"
					maxLenght={9}
					placeholder="UF"
					fieldWidth={30}
				/>
			</ContainerForm>
		</ScrollForm>
	);
}