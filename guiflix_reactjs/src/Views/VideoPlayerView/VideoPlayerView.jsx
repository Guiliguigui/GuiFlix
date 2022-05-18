import './videoplayerview.css';
import React, { useEffect, useRef, useState } from 'react';
import { useLocation, useNavigate } from 'react-router-dom';
import { faArrowLeft } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import EpisodeComponent from '../../Components/EpisodeComponent/EpisodeComponent';
import LoaderComponent from '../../Components/LoaderComponent/LoaderComponent';

export default function VideoPlayerView() {
    const location = useLocation();
    const navigate = useNavigate();
    const videoRef = useRef();
    const [sourceLink,setSourceLink] = useState("");
    const [season,setSeason] = useState("");
    const [isLoading, setIsLoading] = useState(true)
    useEffect(() => {
        setIsLoading(false);
        location.state.type === "TVShow"? setSourceLink(location.state.episodes[0].sourceLink) : setSourceLink("");
    }, [])
    useEffect(()=>{
        videoRef.current?.load();
    },[sourceLink])

    const goBack = () => {
        navigate("/navigation");
    }


    if (isLoading) {
        return (<LoaderComponent />)
    }
    else if (location.state.type === 'Film') {
        return (
            <div className='videoPlayer'>
                <button className="buttonBack" onClick={goBack}><FontAwesomeIcon icon={faArrowLeft} /></button>
                <div className='titlePlayer'>{location.state.name}</div>
                <video controls className='player'><source src={location.state.sourceLink} /></video>
                <div className='descriptionPlayer'>{location.state.description}</div>
            </div>
        )
    }
    else {
        
        return (
            <div className='videoPlayer'>
                <button className="buttonBack" onClick={goBack}><FontAwesomeIcon icon={faArrowLeft} /></button>
                <div className='titlePlayer'>{location.state.name}</div>
                <video controls className='player' ref={videoRef}><source id="episodePlayer" src={sourceLink} type="video/webm" />Error video not find</video>
                <div className='descriptionPlayer'>{location.state.description}</div>
                <div className='episodesList'>
                    {location.state.episodes.map((episode, index) => {
                        return (
                            <EpisodeComponent key={index} episode={episode}  setSourceLink={setSourceLink}/>
                        )
                    })}
                </div>
            </div>
        )
    }
}