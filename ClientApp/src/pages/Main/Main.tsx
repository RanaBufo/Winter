import { Link } from "react-router-dom";

import Header from "@widgets/Header/Header";

import styles from "./ui/Main.module.css";

export default function Main() {
    return (
        <>
            <div className={styles.Main}>
                <div className={styles.Hero}>
                    <h1>Here is - Winter</h1>
                    <div className={styles.HeroButtons}>
                        <Link to="/" className={styles.MainLink}>
                            <svg
                                viewBox="0 0 24 24"
                                className={styles.arr_2}
                                xmlns="http://www.w3.org/2000/svg"
                            >
                                <path d="M16.1716 10.9999L10.8076 5.63589L12.2218 4.22168L20 11.9999L12.2218 19.778L10.8076 18.3638L16.1716 12.9999H4V10.9999H16.1716Z"></path>
                            </svg>
                            <span className={styles.text}>Use Winter</span>
                            <span className={styles.circle}></span>
                            <svg
                                viewBox="0 0 24 24"
                                className={styles.arr_1}
                                xmlns="http://www.w3.org/2000/svg"
                            >
                                <path d="M16.1716 10.9999L10.8076 5.63589L12.2218 4.22168L20 11.9999L12.2218 19.778L10.8076 18.3638L16.1716 12.9999H4V10.9999H16.1716Z"></path>
                            </svg>
                        </Link>
                    </div>
                </div>
            </div>
            <Header />
        </>
    );
}
