import React from 'react';
import Logo from '../../Assets/LogoGuiFlix.png';
import Icon from '../../Assets/GuiFlixIcon.png';
import { Link, useNavigate } from 'react-router-dom';
import { faClapperboard, faTv, faUserFriends, faSignOut} from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import './navbarcomponent.css';

export default function NavBarComponent() {
    
    const navigate = useNavigate();

    function logout() {
        localStorage.removeItem('GuiFlix_JWT')
        navigate("/")
    }
    return (<div className='NavBar'>
        <div className="largeScreen">
            <Link to="/navigation"><img src={Logo} className="p-2" alt="LogoGuiFlix" width={150} /></Link>
            <Link className="linkNavBar" to="/film"><FontAwesomeIcon icon={faClapperboard}/>&nbsp;Films</Link>
            <Link className="linkNavBar" to="/tvshow"><FontAwesomeIcon icon={faTv}/>&nbsp;TV Shows</Link>
            <Link className="linkNavBar navProfiles" to="/profile"><FontAwesomeIcon icon={faUserFriends}/>&nbsp;Profiles</Link>
            <a className="linkNavBar navDisconnect" onClick={e=>logout()} ><FontAwesomeIcon icon={faSignOut}/>&nbsp;Logout</a>
        </div>
        <div className="smallScreen">
            <Link to="/navigation"  ><img src={Icon} className="p-2" alt="LogoGuiFlix" width={40} /></Link>
            <Link className="linkNavBar" to="/film" title='Films'><FontAwesomeIcon icon={faClapperboard}/></Link>
            <Link className="linkNavBar" to="/tvshow" title='TV Shows'><FontAwesomeIcon icon={faTv}/></Link>
            <Link className="linkNavBar navProfiles" to="/profile" title='Profiles'><FontAwesomeIcon icon={faUserFriends}/></Link>
            <a className="linkNavBar navDisconnect" onClick={e=>logout()} title='Logout'><FontAwesomeIcon icon={faSignOut}/></a>
        </div>
    </div>
    );
}