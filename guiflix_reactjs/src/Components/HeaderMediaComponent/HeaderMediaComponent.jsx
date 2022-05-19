import React, { useEffect } from "react";
import './headermediacomponent.css';

export default function HeaderMediaComponent(props) {
    useEffect(()=>{
        document.getElementById("backHeader").style.backgroundImage = "linear-gradient(to right,rgba(0, 0, 0, 1),rgba(12, 12, 12, 0.2),rgba(0, 0, 0, 1)), url(" + props.randomMedia[0].thumbnailLink + ")";
        document.getElementById("backHeader").style.backgroundRepeat = "no-repeat";
        document.getElementById("backHeader").style.backgroundSize = "contain";
        document.getElementById("backHeader").style.backgroundPosition = "center";
        
    })
    return (
        <div className="headerMedia" id="backHeader">
            <div className="textHeaderMedia">
                <div className="titleHeaderMedia">
                    {props.randomMedia[0].name}
                </div>
                <div className="descriptionHeaderMedia">
                    {props.randomMedia[0].description}
                </div>
                <button className="buttonSuite" onClick={(e) => { props.showDetails(props.randomMedia[0].id) }}>Show More...</button>
            </div>
        </div>
    )
}