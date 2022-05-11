import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import LoginView from './Views/LoginView/LoginView';
// import ProfileView from './Views/ProfilesView/ProfileView';
// import FilmView from './Views/FilmView/FilmView';
// import TvShowView from './Views/TvShowView/TvShowView';
import RegisterView from './Views/RegisterView/RegisterView';
// import NavigationView from './Views/NavigationView/NavigationView';
import HomeView from './Views/HomeView/HomeView';
import FAQView from './Views/FAQView/FAQView';
import 'bootstrap/dist/css/bootstrap.min.css';



function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<HomeView />} />
          {/* <Route path="/navigation" element={<NavigationView />} />
          <Route path="/profile" element={<ProfileView />} />
          <Route path="/film" element={<FilmView />} /> */}
          <Route path="/login" element={<LoginView />} />
          {/* <Route path="/tvshow" element={<TvShowView />} /> */}
          <Route path="/register" element={<RegisterView />} />
 
          <Route path="/FAQ" element={<FAQView/>}/>
        </Routes>
      </BrowserRouter>
      
    </div>
  );
}

export default App;
