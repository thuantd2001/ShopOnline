import React from "react";
import { Route, Routes } from 'react-router-dom';
import NavBar from "../components/header/NavBar";
import Home from "../page/home";



export default function RouterCustom() {
    return (
      <React.Fragment>
       <NavBar/>
        <Routes>
          <Route path="/" element={<Home/>} />
     
        </Routes>
      </React.Fragment>
    );
  }
  