import { ButtonProps } from "./Button.props";

import styles from "./Button.module.css";

const Button: React.FC<ButtonProps> = ({ value, styleType, callback }) => {
    const buttonClassName = styleType ? styles[styleType] : styles.Button1;
    const buttonText = value ? value : "Submit";
    

    return <button onClick={() => callback()} className={buttonClassName}>{buttonText}</button>;
};

export default Button;
