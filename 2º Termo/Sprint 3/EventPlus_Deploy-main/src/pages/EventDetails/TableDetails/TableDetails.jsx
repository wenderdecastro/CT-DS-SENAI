import React from "react";
import "./TableDetails.css";
import Title from "../../../components/Title/Title";

const Table = ({ nomeEvento, descricao, dataEvento, comentarios }) => {
    return (
        <table className="tbal-data">
            {
                <thead className="tbal-data__head">
                    <tr className="tbal-data__head-row tbal-data__head-row--red-color">
                        <th className="tbal-data__head-title tbal-data__head-title--big">
                            Nome evento
                        </th>
                        <th className="tbal-data__head-title tbal-data__head-title--big">
                            Data do Evento
                        </th>
                        <th className="tbal-data__head-data tbal-data__head-title--big">
                            Descricao
                        </th>
                    </tr>

                    <tr
                        className="tbal-data__head-row tbal-data__head-row--red-color"
                    >
                        <td className="table-data__data table-data__data--big">
                            {nomeEvento}
                        </td>
                        <td className="table-data__data table-data__data--big">

                            {dataEvento}
                        </td>
                        <td className="table-data__data table-data__data--big">
                            {descricao}
                        </td>
                    </tr>
                </thead>
            }

            <div style={{ margin: 50 + "px" }} >
                <Title titleText={"Comentarios"} />
            </div>  


            <tr className="tbal-data__head-row">
                <th className="tbal-data__head-title tbal-data__head-title--big">Usuario</th>
                <th className="tbal-data__head-title tbal-data__head-title--big">Comentario</th>
            </tr>

            {comentarios.map((c) => {
                return (
                    <tr className="tbal-data__head-row" key={c.idComentarioEvento}>
                        <td className="table-data__data table-data__data--big">{c.usuario.nome}</td>
                        <td className="table-data__data table-data__data--big">{c.descricao}</td>
                    </tr>
                );
            })}
        </table>
    );
};

export default Table;