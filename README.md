# HHSharp

[![](https://img.shields.io/azure-devops/build/swharden/swharden/3?label=Build&logo=azure%20pipelines)](https://dev.azure.com/swharden/swharden/_build/latest?definitionId=1&branchName=master)
[![](https://img.shields.io/azure-devops/tests/swharden/swharden/3?label=Tests&logo=azure%20pipelines)](https://dev.azure.com/swharden/swharden/_build/latest?definitionId=1&branchName=master)

**HHSharp is an interactive Hodgkin-Huxley neuron simulator written in C#.** Analytical routines were designed to be easy to understand, so this program can be used as a learning tool for anyone interested in learning more about Hodgkin-Huxley simulations. [pyHH](https://github.com/swharden/pyHH) is a similar project for Python.

![](dev/screenshot.png)

HHSharp uses a simulation model which calculates channel conductances and membrane potential at discrete time points eliminating the need for a differential equation solver. The core model and simulation routine ([HHModel.cs](src/HHSharp/HHModel.cs)) was written to be easy to understand and is fewer than 100 lines of code. [ScottPlot](https://github.com/swharden/ScottPlot) is used interactively display simulation results.

### Download
* Click-to-run EXE: **[HHSharp.zip](/download/HHSharp.zip)**
* Source code is in: **[src/](/download/)**

## Simulating the Hodgkin–Huxley Model in Software

### Action Potentials in Neural Membranes
Action potentials are self-propagating voltage fluctuations that occur as voltage-gated ion channels open and close. The Hodgkin–Huxley model describes 3 ion channels, two of which contain voltage-dependent gates:
* **voltage-gated Na2+ channel** with 2 voltage-dependent gates (`m` and `h`)
* **voltage-gated K+ channel** with 1 voltage-dependent gate (`n`)
* **K+ leak channel** with no gate

Voltage-gated channel conductances are dependent on gate states. Gate states are dependent on voltage. Voltage is dependent on channel currents and capacitance. Although we can define each item as an equation, these equations depend on each other, meaning they are _differential equations_. The Hodgkin–Huxley model uses a set of four differential equations to describe voltage of a neuron, and we can simulate these equations in software to produce a neuron model which fires action potentials.

![](/dev/theory.png)

### Simulating the _active_ component of neurons

Voltage-dependent ion channel gates don't open or close instantaneously, but rather slowly open and slowly close. Further, different gates open and close at different speeds. It's this phenomenon that is primarily responsible for the generation of action potentials: the excitatory voltage-gated sodium channel activation gate (`m`) is faster to open than the inhibitory voltage-gated potassium channel activation gate (`n`), causing the initial rise in voltage. As the voltage-gated sodium channel inactivation gate (`h`) catches up and inhibitory potassium currents dominate, the cell becomes negative again and resets. 

Our goal in software is to know how much current every channel is passing at each time point. This means calculating the _activation state_ of each gate. Gate activation can be modeled using equations from the Hodgkin–Huxley publication which describe the opening and closing forces as `alpha` and `beta`. Different channels have different time-constants for the opening and closing, and are obviously dependent on membrane voltage. We will handle these operations by creating a `Gate` class which has `alpha`, `beta`, and `activation` properties.

### Simulating the _passive_ component of neurons

After the 3 gates are modeled in software, we can determine the conductance of voltage-gated Na2+ and K+ channels and assume a constant conductance of Kleak channels. By combining these 3 channel conductances with the present membrane voltage and equilibrium potential for Na2+ and K+ we can calculate the channel currents. By summing all channel currents together, we can calculate the total neuron membrane current. When combined with cell capacitance (Cm), we can calculate the change in voltage over a small step in time. 

With this new voltage in-hand we can start over and calculate the voltage-gated channel gate states which are slightly different now because voltage has changed. By iterating this process (typically in 0.01 ms steps) we can simulate the membrane voltage as time passes.

### Additional Resources
* [Hodgkin and Huxley, 1952](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC1392413/pdf/jphysiol01442-0106.pdf) (the original manuscript)
* [The Hodgkin-Huxley Mode](http://www.genesis-sim.org/GENESIS/iBoG/iBoGpdf/chapt4.pdf) (The GENESIS Simulator, Chapter 4)
* Wikipedia: [Hodgkin–Huxley model](https://en.wikipedia.org/wiki/Hodgkin%E2%80%93Huxley_model)
* [Summary of the Hodgkin-Huxley model](http://ecee.colorado.edu/~ecen4831/HHsumWWW/HHsum.html) by Dave Beeman
