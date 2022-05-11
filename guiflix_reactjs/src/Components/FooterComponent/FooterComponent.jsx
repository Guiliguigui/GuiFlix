import React from "react";
import { Link } from "react-router-dom";
import FAQView from "../../Views/FAQView/FAQView";
import './footercomponent.css';

export default function FooterComponent() {
    return (<div className="footer">
        <Link className="link" to="/FAQ" element={<FAQView/>}>FAQ</Link>
    </div>)
}