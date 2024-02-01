import { InputText } from "./style";

export function Input({
  placeholder,
  editable,
  fieldValue,
  onChangeText,
  keyType,
  maxLenght,
}) {
  return (
    <InputText
      placeholder={placeholder}
      editable={editable}
      fieldValue={fieldValue}
      onChangeText={onChangeText}
      keyType={keyType}
      maxLenght={maxLenght}
    />
  );
}