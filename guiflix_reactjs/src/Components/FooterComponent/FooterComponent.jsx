import React from "react";
import { Link } from "react-router-dom";
import './footercomponent.css';

export default function FooterComponent() {
    return (<div className="footer">
        <div className="github">
            <a className="link" href="https://github.com/Romaric98" target="_blank">Romaric</a>
            <a className="link" href="https://github.com/Guiliguigui" target="_blank">Guillaume</a>
            <a className="link" href="https://github.com/YoannLemaire" target="_blank">Yoann</a>
        </div>
        <div className="other">
            <Link className="link" to="/login">Compte</Link>
        </div>
        <div className="corporation">
            GuiFlix Corporation
        </div>
    </div>)
}