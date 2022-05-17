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
import {useState } from 'react';

function App() {
  const [account, setAccount] = useState({});
  const [profileSelected, setProfileSelected] = useState({});
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          {/* Not Authentified */}
          <Route path="/" element={<><HomeView /><FAQView /><FooterComponent /></>} />
          <Route path="/login" element={<><LoginView /><FooterComponent /></>} />
          <Route path="/register" element={<><RegisterView /><FooterComponent /></>} />


          {/* Authentified */}

          <Route path="/profile" element={
            <AuthentifiedView 
              account={account}  
              setAccount={setAccount}
              profileSelected={profileSelected}
              setProfileSelected={setProfileSelected}
              content={<ProfilesView />} 
            />}
          />
          <Route path="/navigation" element={
            <AuthentifiedView 
              account={account}  
              setAccount={setAccount}
              profileSelected={profileSelected}
              setProfileSelected={setProfileSelected}
              content={<NavigationView />} 
            />} 
          />
          <Route path="/film" element={
            <AuthentifiedView 
              account={account}  
              setAccount={setAccount}
              profileSelected={profileSelected}
              setProfileSelected={setProfileSelected}
              content={<NavigationView mediaType="Film" />} 
            />} 
          />
          <Route path="/tvshow" element={
            <AuthentifiedView 
              account={account}  
              setAccount={setAccount}
              profileSelected={profileSelected}
              setProfileSelected={setProfileSelected}
              content={<NavigationView mediaType="TVShow" />} 
            />} 
          />
          {/* <Route path="/news"  element={
            <AuthentifiedView 
              account={account}  
              setAccount={setAccount}
              profileSelected={profileSelected}
              setProfileSelected={setProfileSelected}
              content={<NavigationView />} 
            />} 
          /> */}

        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
