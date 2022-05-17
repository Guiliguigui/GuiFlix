import React from 'react';
import NavBarComponent from '../../Components/NavBarComponent/NavBarComponent';
import FooterComponent from '../../Components/FooterComponent/FooterComponent';
import "./authentifiedview.css";
import { Link , useNavigate} from 'react-router-dom';
import { useState, useEffect } from 'react';
import { post } from '../../Service/Service';
import LoaderComponent from '../../Components/LoaderComponent/LoaderComponent';
import ProfilesView from '../ProfilesView/ProfilesView';

export default function AuthentifiedView(props) {

    const navigate = useNavigate();

    const [isAuthentified, setIsauthentified] = useState(false);
    const [isLoading, setIsLoading] = useState(true);
    //const setAccount2 = (account) => props.setAccount(account);

    useEffect(() => {
        const JWT = localStorage.getItem("GuiFlix_JWT");
        post("Authentication/User/AccountJWT", {},
            {
                headers: { Authorization: `Bearer ${JWT}` }
            }
        ).then(
            res => {
                setIsLoading(false)
                setIsauthentified(true)
                props.setAccount(res.data)
            }
        ).catch(
            err => {
                setIsLoading(false)
                setIsauthentified(false)
            }
        );
    }, []);

    if (isLoading) {
        return (
            <div className='auth align-items-center justify-content-center'>
                <LoaderComponent />
            </div>
        )
    } else if (!isAuthentified) {
        return (
            <div className='auth align-items-center justify-content-center'>
                <div>
                    <h1 className="text-center text-white mb-2">You are not Authentified</h1>
                    <Link to="/" className='btn btn-danger'>Home</Link>
                </div>
            </div>
        )
    } else if (!(props.content.type === ProfilesView) && Object.keys(props.profileSelected).length === 0) {
        navigate("/profile")
    } else {
        return (
            <>
                {props.content.type === ProfilesView ? "" : <NavBarComponent />}
                {React.cloneElement(props.content,
                    {
                        account: props.account,
                        setAccount: props.setAccount,
                        profileSelected: props.profileSelected,
                        setProfileSelected: props.setProfileSelected
                    }
                )}
                <FooterComponent />
            </>
        );
    }
}