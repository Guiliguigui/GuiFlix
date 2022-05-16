import { BrowserRouter, Route, Routes } from 'react-router-dom';
import LoginView from './Views/LoginView/LoginView';
import ProfilesView from './Views/ProfilesView/ProfilesView';
import RegisterView from './Views/RegisterView/RegisterView';
import NavigationView from './Views/NavigationView/NavigationView';
import HomeView from './Views/HomeView/HomeView';
import FooterComponent from './Components/FooterComponent/FooterComponent';
import AuthentifiedView from './Views/AuthentifiedView/AuthentifiedView';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import FAQView from './Views/FAQView/FAQView';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          {/* Not Authentified */}
          <Route path="/" element={<><HomeView /><FAQView /><FooterComponent /></>} />
          <Route path="/login" element={<><LoginView /><FooterComponent /></>} />
          <Route path="/register" element={<><RegisterView /><FooterComponent /></>} />
          {/* Authentified */}
          <Route path="/navigation" element={<AuthentifiedView content={<NavigationView />} />} />
          <Route path="/profile" element={<AuthentifiedView content={<ProfilesView />} />} />
          <Route path="/film" element={<AuthentifiedView content={<NavigationView mediaType="Film" />} />} />
          <Route path="/tvshow" element={<AuthentifiedView content={<NavigationView mediaType="TVShow" />} />} />
          <Route path="/news" element={<AuthentifiedView content={<NavigationView />} />} />

        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
