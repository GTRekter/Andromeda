import React, { Component } from 'react';
import M from 'materialize-css/dist/js/materialize';
import { animateScroll as scroll } from "react-scroll";
import './Footer.css';

export default class Footer extends Component {
    constructor(props) {
        super(props);
        this.onClickScrollToTop = this.onClickScrollToTop.bind(this);
    }
    componentDidMount() {
        var elems = document.querySelectorAll('.tooltipped');
        M.Tooltip.init(elems);
    }
    onClickScrollToTop() {
        scroll.scrollToTop();
    }
    render() {
        return (
            <div className="footer-content">
                <div className="cvitae-container">
                    <ul className="links">
                        <li className="tooltipped" data-position="top" data-delay="50" data-tooltip="Email this Resume">
                            <a href="">
                                <i className="fa fa-envelope-o" aria-hidden="true"/>
                                Email this Resume
                            </a>
                        </li>
                        <li className="tooltipped" data-position="top" data-delay="50" data-tooltip="Fork me on Github">
                            <a href={this.props.info.github} target="_blank">
                                <i className="fa fa-github" aria-hidden="true"/>
                                Github
                            </a>
                        </li>
                        <li className="tooltipped" data-position="top" data-delay="50" data-tooltip="Goto Top">
                            <a data-hover="Goto Top" className="goto-top" onClick={this.onClickScrollToTop}>
                                <i className="fa fa-angle-up" aria-hidden="true"/>
                                Goto Top
                            </a>
                        </li>
                        <li className="tooltipped" data-position="top" data-delay="50" data-tooltip="Follow on Twitter">
                            <a href={this.props.info.twitter} target="_blank">
                                <i className="fa fa-twitter" aria-hidden="true"/>
                                Twitter Profile
                            </a>
                        </li>
                        <li className="tooltipped" data-position="top" data-delay="50" data-tooltip="Follow on Facebook">
                            <a href={this.props.info.facebook} target="_blank">
                                <i className="fa fa-facebook" aria-hidden="true"/>
                                Facebook Profile
                            </a>
                        </li>
                    </ul>
                    <p className="copyright">Copyright {this.props.info.firstname} {this.props.info.lastname} @ 2019</p>
                </div>
            </div>
        );
    }
}
