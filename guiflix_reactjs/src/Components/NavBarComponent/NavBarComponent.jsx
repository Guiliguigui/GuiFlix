import React from 'react';
import { Link } from 'react-router-dom';
import './navbarcomponent.css';

export default function NavBarComponent() {
    return (<div className='NavBar'>
        <Link to="/movies">Movies</Link>
        <Link to="/shows">Shows</Link>
        <Link to="/news">News</Link>
        {//Component profiles
        }
    </div>
    );
}