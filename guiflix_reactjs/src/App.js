import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import LoginView from './Views/LoginView/LoginView';
import ProfileView from './Views/ProfilesView/ProfileView';
import FilmView from './Views/FilmView/FilmView';
import TvShowView from './Views/TvShowView/TvShowView';
import NavigationView from './Views/NavigationView/NavigationView';
import RegistrerView from './Views/RegistrerView/RegistrerView';
import HomeView from './Views/HomeView/HomeView';
import FAQView from './Views/FAQView/FAQView';


function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/login" element={<LoginView />} />
          <Route path="/" element={<HomeView />} />
          <Route path="/navigation" element={<NavigationView />} />
          <Route path="/profile" element={<ProfileView />} />
          <Route path="/film" element={<FilmView />} />
          <Route path="/tvshow" element={<TvShowView />} />
          <Route path="/registrer" element={<RegistrerView />} />
          <Route path="/FAQ" element={<FAQView/>}/>
        </Routes>
      </BrowserRouter>
      
    </div>
  );
}

export default App;
