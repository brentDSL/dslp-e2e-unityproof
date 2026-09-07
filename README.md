# dslp-e2e-unityproof

A synthesized Unity fixture for the DevStreamLabs platform's customer-journey
e2e (`tools/e2e/run_customer_journey.py --engine unity`). One empty scene
carrying `DslpBuildProof`: on its first frame the built player writes
`dslp unityproof ok` to `dslp_unityproof.txt` in its working directory, logs
the same line, and quits. A headless run of the player is the proof that a
real, working player came out of the build.

Authored once with the real editor (`Assets/Editor/DslpFixtureAuthor.cs`,
Unity 6000.0.65f1). No live data of any kind.
