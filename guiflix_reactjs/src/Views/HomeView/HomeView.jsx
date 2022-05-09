import React from "react";
import { Link } from 'react-router-dom';
import Logo from '../../Assets/LogoGuiFlix.png'
import './homeview.css';

export default function HomeView() {
    return (<div className="HomeView">
        <div className="divLink1">
            <Link to="/"><img src={Logo} alt="LogoGuiFlix" width={120} /></Link>
            <Link to="/register"><button className="btn btn-danger">Sign in</button></Link>
        </div>
        <div className="divText">
            <div className="h1Text">Unlimited movies, TV, shows and more.</div>
            <div className="fs-2">Watch anywhere. Cancel at any time.</div>
            <div className="fs-4">Ready to watch? Enter your email to create or restart your membership.</div>
        </div>
        <div className="divLink2">
            <Link to="/login"><button className="btn btn-danger me-5">Connection</button></Link>
            <Link to="/register"><button className="btn btn-danger">Sign in</button></Link>
        </div>

    </div>);
}