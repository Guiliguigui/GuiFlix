import React from 'react';
import NavBarComponent from '../../Components/NavBarComponent/NavBarComponent';
import FooterComponent from '../../Components/FooterComponent/FooterComponent';
import "./authentifiedview.css";
import { Link } from 'react-router-dom';
import { useState } from 'react';
import { post } from '../../Service/Service';
import LoaderComponent from '../../Components/LoaderComponent/LoaderComponent';
import ProfilesView from '../ProfilesView/ProfilesView';

export default function AuthentifiedView(props) {
    const [isAuthentified, setIsauthentified] = useState(false);
    const [isLoading, setIsLoading] = useState(true);
    // jwt token test => true set localstorage account
    const JWT = localStorage.getItem("GuiFlix_JWT");
    console.log(JWT);
    post("Authentication/User/AccountJWT", {},
    {
        headers: {Authorization : `Bearer ${JWT}`}
    }
    ).then(
        res => {
            setIsLoading(false)
            setIsauthentified(true)
        } 
    ).catch(
        err => {
            setIsLoading(false)
            setIsauthentified(false)
        }
    );


    if (isLoading) {
        return(
            <div className='auth align-items-center justify-content-center'>
                <LoaderComponent />
            </div>
        )
    }
    else if (!isAuthentified) {
        return (
            <div className='auth align-items-center justify-content-center'>
                <div>
                    <h1 className="text-center text-white mb-2">You are not Authentified</h1>
                    <Link to="/" className='btn btn-danger'>Home</Link>
                </div>
            </div>
        )
    } else {
        return (
            <>
                {props.content.type === ProfilesView ? "": <NavBarComponent />}
                {props.content}
                <FooterComponent />
            </>
        );
    }
}