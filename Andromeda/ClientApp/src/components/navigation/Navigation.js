import React, { Component } from 'react';
import { Link, animateScroll as scroll } from "react-scroll";
import './Navigation.css';

export default class Navigation extends Component {
    constructor(props) {
        super(props);
        this.onClickScrollToTop = this.onClickScrollToTop.bind(this);
    }
    onClickScrollToTop() {
        scroll.scrollToTop();
    }
    render() {
        return (
            <div className="cvitae-menu-wrapper">
                <nav className="cvitae-main-nav scroll">
                    <ul>
                        <li className="waves-effect waves-cvitae">
                            <Link activeClass="active" to="about" smooth="true" offset={-70} duration={500}>
                            About
                            </Link>
                        </li>
                        <li className="waves-effect waves-cvitae">
                            <Link activeClass="active" to="skills" smooth="true" offset={-70} duration={500}>
                            Skills
                            </Link>
                        </li>
                        <li className="waves-effect waves-cvitae">
                            <Link activeClass="active" to="education" smooth="true" offset={-70} duration={500}>
                                Education
                            </Link>
                        </li>
                        <li className="cvitae-home waves-effect">
                            <a onClick={this.onClickScrollToTop}>Ivan Porta</a>
                        </li>
                        <li className="waves-effect waves-cvitae">
                            <Link activeClass="active" to="testimonial" smooth="true" offset={-70} duration={500}>
                                Testimony
                            </Link>
                        </li>
                        <li className="waves-effect waves-cvitae">
                            <Link activeClass="active" to="experience" smooth="true" offset={-70} duration={500}>
                                Experience
                            </Link>
                        </li>
                        <li className="waves-effect waves-cvitae">
                            <Link activeClass="active" to="contact" smooth="true" offset={-70} duration={500}>
                                Contact
                            </Link>
                        </li>
                    </ul>
                </nav>
            </div>
        );
    }
}
