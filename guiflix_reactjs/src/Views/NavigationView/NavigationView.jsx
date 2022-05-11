import React from "react";
import HeaderMediaComponent from "../../Components/HeaderMediaComponent/HeaderMediaComponent";
import MediaListComponent from "../../Components/MediaListComponent/MediaListComponent";
import './navigationview.css';

export default function NavigationView(){
    return (<>
    <HeaderMediaComponent/>
    <MediaListComponent/>
    </>)
}