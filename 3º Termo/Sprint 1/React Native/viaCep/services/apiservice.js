import axios from "axios";

const viaCep = axios.create({ baseURL: "https://viacep.com.br/ws/" });
const ibge = axios.create({
	baseURL: "https://servicodados.ibge.gov.br/api/v1/localidades/estados/",
});

export async function getCep(cep) {
	try {
		const dataViaCep = (await viaCep.get(`${cep}/json`)).data;
		const dataIbge = (await ibge.get(dataViaCep.uf)).data;

		let finalAdress = {
			cep: dataViaCep.cep,
			logradouro: dataViaCep.logradouro,
			localidade: dataViaCep.localidade,
			uf: dataViaCep.uf,
			bairro: dataViaCep.bairro,
            estado: dataIbge.nome
		}

		if(dataViaCep.uf == null) return;
        
		console.log("Endereço encontrado" + finalAdress);

		return finalAdress;

	} catch (error) {
		console.error("Erro ao buscar o endereço. " + error);
	}
}

console.log("Endereço não encontrado");
