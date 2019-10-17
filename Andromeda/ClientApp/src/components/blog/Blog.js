import React, { Component } from 'react';
import './Blog.css';

export default class Blog extends Component {
    render() {
        return (
            <div id="blog" className="cvitae-section cvitae-blog">
                <div className="cvitae-container">
                    <div className="cvitae-section-content">
                        <div className="content-left">
                            <h3 className="cvitae-section-title">Blog</h3>
                            <p>To enrich knowledge, I am lucky to get certified from several famous institutions in our locality. Here I enlisted my top certifications.</p>
                            <p>Beside there, I had been awarded as Top Scorer in Math &amp; Physics during my grad school.</p>
                            <a href="#" className="view-all">View all</a>
                        </div>
                        <div className="content-right">
                            <div className="blog-container">
                                <div className="post">
                                    <div className="thumb"><a href="blog-single.html" target="_blank"><img src="img/blog/1.jpg" alt="Blog 1"></a></div>
                                        <h3 className="title"><a href="blog-single.html" target="_blank">How To Install Wordpress Theme - Step By Step</a></h3>
                                    </div>
                                    <div className="post">
                                        <div className="thumb"><a href="blog-single.html" target="_blank"><img src="img/blog/2.jpg" alt="Blog 2"></a></div>
                                            <h3 className="title"><a href="blog-single.html" target="_blank">How To Become A Successful Author</a></h3>
                                        </div>
                                        <div className="post">
                                            <div className="thumb"><a href="blog-single.html" target="_blank"><img src="img/blog/3.jpg" alt="Blog 3"></a></div>
                                                <h3 className="title"><a href="blog-single.html" target="_blank">Its A Pro Thing To Have An Online Resume</a></h3>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}