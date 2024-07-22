<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Gate;

class HomeController extends Controller
{
    public function __construct(){
        $this->middleware('auth');
    }

    public function index()
    {
        return view('home');
    }

    // public function admin()
    // {
    //     if(Gate::allows('is-admin'))
    //         return view('admin');
    //     else
    //         abort(403);
    // }
}
