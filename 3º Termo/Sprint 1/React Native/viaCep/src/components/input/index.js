import { InputText } from "./style";

export function Input({
  placeholder,
  editable = false,
  fieldValue = null,
  onChangeText = null,
  keyType = 'default',
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