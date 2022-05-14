import { get } from "../../Service/Service";
import React, { useState } from "react";
import HeaderMediaComponent from "../../Components/HeaderMediaComponent/HeaderMediaComponent";
import MediaDetailsComponent from "../../Components/MediaDetailsComponent/MediaDetailsComponent";
import MediaListComponent from "../../Components/MediaListComponent/MediaListComponent";
import './navigationview.css';

export default function NavigationView() {
    const [randomMedia, setRandomMedia] = useState([]);
    const [isDetails, setIsDetails] = useState(false);
    const showDetails = (id) => {
        get("Media/" + id).then((res) => {
            setRandomMedia(res.data);
            setIsDetails(true)
        })
        document.getElementById("navigationView").style.opacity = 0.7;
    }
    return (
        <div id="navigationView">
            {isDetails ? <MediaDetailsComponent randomMedia={randomMedia[0]} setIsDetails={setIsDetails} /> : ""}
            <HeaderMediaComponent showDetails={showDetails} />
            <MediaListComponent />
        </div>
    )
}