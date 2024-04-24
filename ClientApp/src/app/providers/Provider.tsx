import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

// Pages importation
import Login from "@pages/Login/Login";
import Register from "@pages/Register/Register";
import Main from "@pages/Main/Main";
import Error404 from "@pages/Error404/Error404";

export default function Provider() {
    return (
        <Router>
            <Routes>
                <Route path="/login" element={<Login />} />
                <Route path="/register" element={<Register />} />
                <Route path="/" element={<Main />} />
                <Route path="/*" element={<Error404 />} />
            </Routes>
        </Router>
    );
}
