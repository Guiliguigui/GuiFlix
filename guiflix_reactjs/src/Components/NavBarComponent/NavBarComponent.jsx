import React from 'react';
import Logo from '../../Assets/LogoGuiFlix.png';
import Icon from '../../Assets/GuiFlixIcon.png';
import { Link } from 'react-router-dom';
import './navbarcomponent.css';

export default function NavBarComponent() {
    return (<div className='NavBar'>
        <div className="largeScreen">
            <Link to="/"  ><img src={Logo} className="p-2" alt="LogoGuiFlix" width={150} /></Link>
            <Link className="linkNavBar" to="/movies">Movies</Link>
            <Link className="linkNavBar" to="/shows">Shows</Link>
            <Link className="linkNavBar" to="/news">News</Link>
            {//Component profiles
            }
        </div>
        <div className="smallScreen">
            <Link to="/"  ><img src={Icon} className="p-2" alt="LogoGuiFlix" width={40} /></Link>
            <Link className="linkNavBar" to="/movies" title='Movies'>M</Link>
            <Link className="linkNavBar" to="/shows" title='Shows'>S</Link>
            <Link className="linkNavBar" to="/news" title='News'>N</Link>
        </div>
    </div>
    );
}