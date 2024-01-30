import styled from "styled-components/native";

export const Button = styled.TouchableOpacity`
    width: 150px;
    height: 40px;
    border-radius: 10px;
    background-color: ${(props) => props.buttonColor};
    display: flex;
    justify-content: center;
    align-items: center;
    margin: 15px;
`;

export const ButtonText = styled.Text`
    color: #1b2c3d; 
    font-size:20px; 
    /* font-family:  */
`;