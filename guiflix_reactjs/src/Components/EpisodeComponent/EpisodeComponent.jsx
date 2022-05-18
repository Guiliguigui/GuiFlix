import React from "react";
import { faPlayCircle } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import './episodecomponent.css';

export default function EpisodeComponent(props) {
    const playEpisode = ()=>{
        props.setSourceLink(props.episode.sourceLink);
        props.setCurrentEpisode(props.episode.name);
    }
    return (
        <div className="episode">
            <div className="titleEpisode">
                {props.episode.episodeNumber}&nbsp;{props.episode.name}
                <img className="imgEpisode" src={props.episode.thumbnailLink} alt="episode" />
            </div>
            <div className="descriptionEpisode">{props.episode.description}</div>
            <button className="buttonEpisode" onClick={() => { playEpisode() }}><FontAwesomeIcon icon={faPlayCircle} /></button>
        </div>
    )
}