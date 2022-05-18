import React from "react";
import './episodecomponent.css';

export default function EpisodeComponent(props){
    return(
    <div className="episode">
        <button onClick={this.props.changeEpisode(props.episode.sourceLink)}>V</button>
        {props.episode.episodeNumber}
    </div>
    )
}