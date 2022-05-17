import { get } from "../../Service/Service";
import React, { useEffect, useState } from "react";
import HeaderMediaComponent from "../../Components/HeaderMediaComponent/HeaderMediaComponent";
import MediaDetailsComponent from "../../Components/MediaDetailsComponent/MediaDetailsComponent";
import MediaListComponent from "../../Components/MediaListComponent/MediaListComponent";
import './navigationview.css';
import LoaderComponent from "../../Components/LoaderComponent/LoaderComponent";

export default function NavigationView() {
    const [randomMedia, setRandomMedia] = useState([]);
    const [media,setMedia] = useState([]);
    const [isDetails, setIsDetails] = useState(false);
    const [isHeaderLoading, setIsHeaderLoading] = useState(true);


    useEffect(()=>{
        isDetails? document.getElementById("blurDiv").style.filter = "blur(7px)" : document.getElementById("blurDiv").style.filter = "blur(0)"
    },[isDetails])
    useEffect(()=>{
        get("Media/Random?quantity=1").then((res) => {
            setRandomMedia(res.data);
            setIsHeaderLoading(false);
        })
    },[])
    const showDetails = (id) => {
        get("Media/" + id).then((res) => {
            setMedia(res.data);
            setIsDetails(true);
        })
    }
    
    return (
        <div id="navigationView">
            <div id="blurDiv">
                {isHeaderLoading? <LoaderComponent/> : <HeaderMediaComponent showDetails={showDetails} randomMedia={randomMedia}/>}
                <MediaListComponent showDetails={showDetails} />
            </div>
            {
                isDetails ? <MediaDetailsComponent mediaId={media.id} setIsDetails={setIsDetails} /> : ""
            }
        </div>
    )
}