import Header from "@widgets/Header/Header";
import Button from "@shared/Button/Button";
import Input from "@shared/Input/Input";

export default function Login() {
    return (
        <>
            <Header />
            <p>Login page</p>
            <form method="post">
                <Input styleType="Input2" placeholderValue="Email" required/>
                <Input styleType="Input2" placeholderValue="Password" required/>
                <Button styleType="Button1" value="Sing in"/>
            </form>
        </>
    );
}
