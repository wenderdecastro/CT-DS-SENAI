
import { Input } from "../input";
import { InputText } from "../input/style";
import { Label } from "../label";
import { FieldContent } from "./style";

export const ContainerInput = ({
	fieldWidth = 100,
	editable = false,
	placeholder,
	textLabel,
	fieldValue = null,
	onChangeText = null,
	keyType = "default",
	maxLenght,
}) => {
	return (
		<FieldContent fieldWidth={fieldWidth}>
			<Label textLabel={textLabel} />
			<Input
				placeholder={placeholder}
				editable={editable}
				keyType={keyType}
				maxLenght={maxLenght}
				fieldValue={fieldValue}
				onChangeText={onChangeText}
			/>
		</FieldContent>
	);
};
