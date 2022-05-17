import React, { useEffect, useState } from "react";
import { get } from "../../Service/Service";
import { faAngleLeft, faAngleRight } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import './medialistcomponent.css';
import LoaderComponent from "../LoaderComponent/LoaderComponent";

export default function MediaListComponent(props) {
    const [mediaList, setMediaList] = useState([]);
    const [isLoaded, setIsLoading] = useState(true);
    useEffect(() => {
        get("Media/Random?Quantity=5").then((res) => {
            setMediaList(res.data)
            setIsLoading(false);
        })
    }, [])
    const details = (id) => {
        document.getElementById(id).style.visibility = "visible";
    }
    const hideDetails = (id) => {
        document.getElementById(id).style.visibility = "hidden";

    }
    const goBack = () => {
        document.getElementById("mediaCarousel").style.transform = "translateX(-20%)"

    }
    const goForward = () => {
        document.getElementById("mediaCarousel").style.transform = "translateX(20%)"
    }
    useEffect(() => {
        get("Media/")
    })
    return (
        <div className="carousel">
            <div className="titleCarousel">
                Categorie
            </div>
            <div className="contentCarousel">
                <button className="buttonCarousel" onClick={goBack}><FontAwesomeIcon icon={faAngleLeft} /></button>
                <div className="mediaCarousel">
                    {isLoaded ? <LoaderComponent /> : mediaList.map((media, index) => {
                        return (
                                <div onMouseEnter={(e) => { details(media.id) }} onMouseLeave={(e) => { hideDetails(media.id) }} className="mediaCard" style={{ backgroundImage: "url(" + media.thumbnailLink + ")"}} key={index}>
                                    <div onClick={(e) => { props.showDetails(media.id) }} className="detailsMedia" id={media.id}>{media.name}<br />Show more...</div>
                                </div>
                        )
                    })}
                </div>
                <button className="buttonCarousel" onClick={goForward}><FontAwesomeIcon icon={faAngleRight} /></button>
            </div>
        </div>
    )
}