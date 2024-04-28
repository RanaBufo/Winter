import { Link } from "react-router-dom";

import Header from "@widgets/Header/Header";

import styles from "./ui/Main.module.css";
import Button from "@shared/Button/Button";

export default function Main() {
    return (
        <>
            <div className={styles.Main}>
                <div className={styles.Hero}>
                    <h1>Here is - Winter</h1>
                    <div className={styles.HeroButtons}>
                        <Link to="/login">
                            <Button
                                value="Use Winter"
                                styleType="Button1"
                                onClick={() => console.log("hello")}
                            />
                        </Link>
                    </div>
                </div>
            </div>
            <Header />
        </>
    );
}
