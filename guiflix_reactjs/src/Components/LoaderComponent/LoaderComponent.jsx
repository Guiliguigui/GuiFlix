import React from "react";
import './loadercomponent.css';
import { faArrowRotateRight } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

export default function LoaderComponent(){
    return(
    <div className="loader">
        <FontAwesomeIcon className="iconArrowRotate" icon={faArrowRotateRight}/>
    </div>
    )
}