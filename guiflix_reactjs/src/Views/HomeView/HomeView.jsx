import React from "react";
import { Link } from 'react-router-dom';
import Logo from '../../Assets/LogoGuiFlix.png'
import './homeview.css';

export default function HomeView() {
    return (<div className="HomeView">
        <div className="divLink1">
            <Link to="/"><img src={Logo} alt="LogoGuiFlix" width={200} /></Link>
            <Link to="/register"><button className="btn btn-danger">Register</button></Link>
        </div>
        <div className="divText">
            <div className="h1Text">Unlimited movies, TV, shows and more.</div>
            <div className="displayText1">Watch anywhere. Cancel at any time.</div>
            <div className="displayText2">Ready to watch? Enter your email to create or restart your membership.</div>
        </div>
        <div className="divLink2">
            <Link to="/login"><button className="btnHome btn-lg btn-danger me-5">Login</button></Link>
            <Link to="/register"><button className="btnHome btn-lg btn-danger">Register</button></Link>
        </div>
    </div>
    );
}