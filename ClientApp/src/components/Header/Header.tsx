import {NavLink} from 'react-router-dom';

import styles from './Header.module.css'

export default function Header() {
    return (
        <header className={styles.Header}>
            <NavLink to="/login">Login</NavLink>
            <NavLink to="/register">Register</NavLink>
            <NavLink to="/">Main</NavLink>
        </header>
    );
}