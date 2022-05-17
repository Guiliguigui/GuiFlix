import React, { useEffect, useState } from "react";
import './mediadetailscomponent.css';
import { faXmark,faPlayCircle } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { get } from "../../Service/Service";
import LoaderComponent from "../LoaderComponent/LoaderComponent";

export default function MediaDetailsComponent(props) {
const [media,setMedia] = useState([]);
const [isLoading,setIsLoading] = useState(true);
useEffect(()=>{
    get("Media/"+props.mediaId).then((res)=>{
        setMedia(res.data);
        setIsLoading(false)
    })
},[])
    const close=()=>{
        props.setIsDetails(false);
    }
    
    return (
        isLoading? <LoaderComponent/> :
    <div className="mediaDetails">
        <div className="headerDetails">
        <div className="titleDetails">{media.name}</div>
        <button onClick={close} className="buttonClose"><FontAwesomeIcon icon={faXmark}/></button>
        </div>
        <div className="contentDetails" style={{backgroundImage:"url("+media.thumbnailLink+")"}}>
            <div className="descriptionDetails">{media.description}</div>
            <div className="crewMembersDetails">With: {media.crewMembers.map((crewMember,index)=>{
                return(<span key={index}> {crewMember.crewMember.firstName} {crewMember.crewMember.lastName}</span>)
            })}
            </div>
            <div className="bottomDetails">
                <button className="buttonPlay"><FontAwesomeIcon icon={faPlayCircle}/></button>
                <div className="durationMedia">{media.duration}</div>
                </div>
            
        </div>
        
    </div>
    )
}