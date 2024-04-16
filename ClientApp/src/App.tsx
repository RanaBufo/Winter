import {
  BrowserRouter as Router,
  Route,
  Routes,
} from 'react-router-dom'

// Pages importation
import Login from './components/Login/Login'
import Register from './components/Register/Register'
import Main from './components/Main/Main'
import Error404 from './components/Error404/Error404'

// Styling
import './App.css'

function App() {
  return (
    <Router>
      <Routes>
        <Route 
          path="/login"
          element={<Login />}
        />
        <Route 
          path="/register"
          element={<Register />}
        />
        <Route 
          path="/"
          element={<Main />}
        />
        <Route
          path="/*"
          element={<Error404 />}
        />
      </Routes>
    </Router>
  )
}

export default App
