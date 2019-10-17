import React, { Component } from 'react';
import { Link } from "react-scroll";
import jQuery from 'jquery';
import './NavigationMobile.css';

export default class NavigationMobile extends Component {
    componentDidMount() {
        jQuery('.mobile-site-menu').on('click', function () {
            jQuery('.cvitae-mobile-navigation').toggleClass('active');
        });

        jQuery('.cvitae-mobile-nav a').on('click', function () {
            jQuery('.cvitae-mobile-navigation').removeClass('active');
        });

    }
    render() {
        return (
            <div className="cvitae-mobile-navigation">
                <div className="nav-header">
                    <span className="fa fa-bars mobile-site-menu" />
                    <a className="mobile-site-title" onClick={this.onClickScrollToTop}>Ivan Porta</a>
                </div>
                <nav className="cvitae-mobile-nav scroll">
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
