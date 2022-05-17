import React from "react";
import './episodecomponent.css';

export default function EpisodeComponent(props){
    return(
    <div className="bg-danger">
        Hello
        {props.episode.episodeNumber}
        {console.log(props)}
    </div>
    )
}