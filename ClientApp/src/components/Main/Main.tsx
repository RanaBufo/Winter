import Header from '../Header/Header'

import styles from './Main.module.css'

export default function Main() {
    return(
    <>
        <div className={styles.Main}>
            <div className={styles.Hero}>
                <h1>Here is - Winter 🥶</h1>
            </div>
        </div>
        <Header />
    </>
    );
}
