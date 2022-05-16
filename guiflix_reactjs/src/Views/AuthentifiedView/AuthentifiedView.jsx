import React from 'react';
import NavBarComponent from '../../Components/NavBarComponent/NavBarComponent';
import FooterComponent from '../../Components/FooterComponent/FooterComponent';
import "./authentifiedview.css";
import { Link } from 'react-router-dom';
import { useState } from 'react';
import { post } from '../../Service/Service';
import LoaderComponent from '../../Components/LoaderComponent/LoaderComponent';

export default function AuthentifiedView(props) {
    const [isAuthentified, setIsauthentified] = useState(true);
    const [isLoading, setIsLoading] = useState(false);
    //jwt token test => true set localstorage account
    // post("Authentication/User/AccountJWT", config ={
    //     headers: {
    //        Authorization: "Bearer " + JWTToken
    //     }
    // }).then(res => {


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
                <NavBarComponent />
                {props.content}
                <FooterComponent />
            </>
        );
    }
}