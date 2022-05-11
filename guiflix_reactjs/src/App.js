import { BrowserRouter, Route, Routes } from 'react-router-dom';
import { Fragment } from 'react';
import LoginView from './Views/LoginView/LoginView';
import ProfileView from './Views/ProfilesView/ProfileView';
import FilmView from './Views/FilmView/FilmView';
import TvShowView from './Views/TvShowView/TvShowView';
import RegisterView from './Views/RegisterView/RegisterView';
import NavigationView from './Views/NavigationView/NavigationView';
import HomeView from './Views/HomeView/HomeView';
import FooterComponent from './Components/FooterComponent/FooterComponent';
import NavBarComponent from './Components/NavBarComponent/NavBarComponent';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Fragment><HomeView /><FooterComponent/></Fragment>} />
           <Route path="/navigation" element={<Fragment><NavBarComponent/><NavigationView /><FooterComponent/></Fragment>} />
          <Route path="/profile" element={<ProfileView />} />
          <Route path="/film" element={<FilmView />} />
          <Route path="/login" element={<LoginView />} />
           <Route path="/tvshow" element={<TvShowView />} />
          <Route path="/register" element={<RegisterView />} />
        </Routes>
      </BrowserRouter>
      
    </div>
  );
}

export default App;
