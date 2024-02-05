import { InputText } from "./style";

export function Input({
  placeholder,
  editable = false,
  fieldValue,
  onChangeText,
  keyType = 'default',
  maxLenght,
}) {
  return (
    <InputText placeholderTextColor={'#a1a1a1'}
      placeholder={placeholder}
      editable={editable}
      value={fieldValue}
      onChangeText={onChangeText}
      keyType={keyType}
      maxLenght={maxLenght}
    />
  );
}