import React, { useState } from "react";
import HeaderMediaComponent from "../../Components/HeaderMediaComponent/HeaderMediaComponent";
import MediaDetailsComponent from "../../Components/MediaDetailsComponent/MediaDetailsComponent";
import MediaListComponent from "../../Components/MediaListComponent/MediaListComponent";
import './navigationview.css';

export default function NavigationView(){
    const [isDetails,setIsDetails]= useState(false);
     function showDetails(media){
        isDetails? setIsDetails(false) : setIsDetails(true);
        return(<MediaDetailsComponent media={media}/>)
    }
    return (<div className="navigation" id="navigationView">
    <HeaderMediaComponent showDetails={showDetails}/>
    <MediaListComponent/>
    </div>)
}