import React, { useEffect} from "react";
import { get } from "../../Service/Service";
import { faAngleLeft, faAngleRight } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import './medialistcomponent.css';

export default function MediaListComponent(props) {
    let index = 0;
    const details = (id) => {
        document.getElementById(id).style.visibility = "visible";
    }
    const hideDetails = (id) => {
        document.getElementById(id).style.visibility = "hidden";

    }
    const goBack = () => {
        if (index > 0) {
            index--;
            document.getElementById(props.nameCarousel).style.transform = "translateX(-" + index * 360 + "px)"
        }
    }
    const goForward = () => {
        if (index < (props.medias.length - 1)) {
            index++;
            document.getElementById(props.nameCarousel).style.transform = "translateX(-" + index * 360 + "px)"
        }
    }
    useEffect(() => {
        get("Media/")
    })
    return (
        <div className="carousel">
            <div className="titleCarousel">
                {props.nameCarousel}
            </div>
            <button className="buttonPrevCarousel" onClick={goBack}><FontAwesomeIcon icon={faAngleLeft} /></button>
            <div className="contentCarousel">
                <div className="mediaCarousel" id={props.nameCarousel}>
                    { props.medias.map((media, index) => {
                        return (
                            <div onMouseEnter={(e) => { details(media.id) }} onMouseLeave={(e) => { hideDetails(media.id) }} className="mediaCard" style={{ backgroundImage: "url(" + media.thumbnailLink + ")" }} key={index}>
                                <div onClick={(e) => { props.showDetails(media.id) }} className="detailsMedia" id={media.id}>{media.name}<br />Show more...</div>
                            </div>
                        )
                    })}
                </div>
            </div>
            <button className="buttonNextCarousel" onClick={goForward}><FontAwesomeIcon icon={faAngleRight} /></button>
        </div>
    )
}