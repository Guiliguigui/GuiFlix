import React from 'react';
import "./mediacardcomponent.css";

function MediaCardComponent(props) {
    
    const details = (id) => {
        document.getElementById(id).style.visibility = "visible";
    }
    const hideDetails = (id) => {
        document.getElementById(id).style.visibility = "hidden";
    }

    return (
        <div onMouseEnter={(e) => { details(props.UniqId) }} onMouseLeave={(e) => { hideDetails(props.UniqId) }} className="mediaCard" style={{ backgroundImage: "url(" + props.media.thumbnailLink + ")" }}>
            <div onClick={(e) => { props.showDetails(props.media.id) }} className="detailsMedia" id={props.UniqId}>{props.media.name}<br />Show more...</div>
        </div>
    );
}

export default MediaCardComponent;