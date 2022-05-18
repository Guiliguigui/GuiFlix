import React, { useEffect } from "react";
import { get } from "../../Service/Service";
import { faAngleLeft, faAngleRight } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { v4 as uuidv4 } from 'uuid';
import './medialistcomponent.css';
import MediaCardComponent from "../MediaCardComponent/MediaCardComponent";

export default function MediaListComponent(props) {
    let index = 0;
    const goBack = () => {
        if (index > 0) {
            index--;
            document.getElementById(props.nameCarousel).style.transform = "translateX(-" + index * 360 + "px)"
        }
        else {
            index = props.medias.length - 1;
            document.getElementById(props.nameCarousel).style.transform = "translateX(-" + index * 360 + "px)"
        }
    }
    const goForward = () => {
        if (index < (props.medias.length - 1)) {
            index++;
            document.getElementById(props.nameCarousel).style.transform = "translateX(-" + index * 360 + "px)"
        }
        else {
            index = 0;
            document.getElementById(props.nameCarousel).style.transform = "translateX(-" + index * 360 + "px)"
        }
    }
    return (
        <div className="carousel">
            <div className="titleCarousel">
                {props.nameCarousel}
            </div>
            <button className="buttonPrevCarousel" onClick={goBack}><FontAwesomeIcon icon={faAngleLeft} /></button>
            <div className="contentCarousel">
                <div className="mediaCarousel" id={props.nameCarousel}>
                    {props.medias.map((media, index) => {
                        var UniqId = uuidv4();
                        return (
                            <MediaCardComponent showDetails={props.showDetails} media={media} key={UniqId} UniqId={UniqId}/>
                        )
                    })}
                </div>
            </div>
            <button className="buttonNextCarousel" onClick={goForward}><FontAwesomeIcon icon={faAngleRight} /></button>
        </div>
    )
}